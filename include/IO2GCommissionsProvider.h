#pragma once

/** Description of the single commission.
*/
class IO2GCommissionDescription : public IAddRef
{
protected:

    IO2GCommissionDescription(){};

public:

    virtual O2GCommissionStage getStage() = 0;

    virtual O2GCommissionUnitType getUnitType() = 0;
    
    virtual double getCommissionValue() = 0;

    virtual double getMinCommission() = 0;
};

class IO2GCommissionDescriptionsCollection : public IAddRef
{
protected:

    IO2GCommissionDescriptionsCollection(){};

public:

    virtual int size() = 0;

    virtual IO2GCommissionDescription* get(int i) = 0;
};

class IO2GCommissionProviderListener : public IAddRef
{
public:

    virtual void onChangeCommissionProviderStatus(O2GCommissionStatus status) = 0;

    virtual void onNeedUpdateCommissions() = 0;
};

/** Main commission interface (used to access all commissions related information).*/
class IO2GCommissionsProvider : public IAddRef
{
 protected:
    IO2GCommissionsProvider(){};
 public:

    /** Gets condition distance for the stop. */
    virtual IO2GCommissionDescriptionsCollection* getCommissionDescriptions(const char* offerID, const char* accountID) = 0;    

    /** Gets the current status. */
    virtual O2GCommissionStatus getStatus() = 0;
    virtual void subscribe(IO2GCommissionProviderListener *listener) = 0;
    virtual void unsubscribe(IO2GCommissionProviderListener *listener) = 0;

    //Methoods to calculte commissions
    virtual double calcOpenCommission(const char* offerID, const char* accountID, int amount, const char* buySell) = 0;
    virtual double calcCloseCommission(const char* offerID, const char* accountID, int amount, const char* buySell) = 0;
    virtual double calcTotalCommission(const char* offerID, const char* accountID, int amount, const char* buySell) = 0;
};


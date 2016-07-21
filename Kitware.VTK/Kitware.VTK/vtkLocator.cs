using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkLocator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLocator";

		public new static readonly string MRClassNameKey;

		static vtkLocator()
		{
			vtkLocator.MRClassNameKey = "class vtkLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLocator"));
		}

		public vtkLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_Register_20(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkLocator.vtkLocator_Register_20(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_UnRegister_26(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkLocator.vtkLocator_UnRegister_26(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_AutomaticOff_01(HandleRef pThis);

		public virtual void AutomaticOff()
		{
			vtkLocator.vtkLocator_AutomaticOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_AutomaticOn_02(HandleRef pThis);

		public virtual void AutomaticOn()
		{
			vtkLocator.vtkLocator_AutomaticOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_BuildLocator_03(HandleRef pThis);

		public virtual void BuildLocator()
		{
			vtkLocator.vtkLocator_BuildLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_FreeSearchStructure_04(HandleRef pThis);

		public virtual void FreeSearchStructure()
		{
			vtkLocator.vtkLocator_FreeSearchStructure_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_GenerateRepresentation_05(HandleRef pThis, int level, HandleRef pd);

		public virtual void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkLocator.vtkLocator_GenerateRepresentation_05(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_GetAutomatic_06(HandleRef pThis);

		public virtual int GetAutomatic()
		{
			return vtkLocator.vtkLocator_GetAutomatic_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkLocator_GetBuildTime_07(HandleRef pThis);

		public virtual uint GetBuildTime()
		{
			return vtkLocator.vtkLocator_GetBuildTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkLocator_GetDataSet_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLocator.vtkLocator_GetDataSet_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_GetLevel_09(HandleRef pThis);

		public virtual int GetLevel()
		{
			return vtkLocator.vtkLocator_GetLevel_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_GetMaxLevel_10(HandleRef pThis);

		public virtual int GetMaxLevel()
		{
			return vtkLocator.vtkLocator_GetMaxLevel_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_GetMaxLevelMaxValue_11(HandleRef pThis);

		public virtual int GetMaxLevelMaxValue()
		{
			return vtkLocator.vtkLocator_GetMaxLevelMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_GetMaxLevelMinValue_12(HandleRef pThis);

		public virtual int GetMaxLevelMinValue()
		{
			return vtkLocator.vtkLocator_GetMaxLevelMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkLocator_GetTolerance_13(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkLocator.vtkLocator_GetTolerance_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkLocator_GetToleranceMaxValue_14(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkLocator.vtkLocator_GetToleranceMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkLocator_GetToleranceMinValue_15(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkLocator.vtkLocator_GetToleranceMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_Initialize_16(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkLocator.vtkLocator_Initialize_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLocator.vtkLocator_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkLocator_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLocator.vtkLocator_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkLocator_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLocator NewInstance()
		{
			vtkLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLocator.vtkLocator_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkLocator_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLocator SafeDownCast(vtkObjectBase o)
		{
			vtkLocator vtkLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLocator.vtkLocator_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLocator = (vtkLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLocator.Register(null);
				}
			}
			return vtkLocator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_SetAutomatic_22(HandleRef pThis, int _arg);

		public virtual void SetAutomatic(int _arg)
		{
			vtkLocator.vtkLocator_SetAutomatic_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_SetDataSet_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkLocator.vtkLocator_SetDataSet_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_SetMaxLevel_24(HandleRef pThis, int _arg);

		public virtual void SetMaxLevel(int _arg)
		{
			vtkLocator.vtkLocator_SetMaxLevel_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_SetTolerance_25(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkLocator.vtkLocator_SetTolerance_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkLocator_Update_27(HandleRef pThis);

		public virtual void Update()
		{
			vtkLocator.vtkLocator_Update_27(base.GetCppThis());
		}
	}
}

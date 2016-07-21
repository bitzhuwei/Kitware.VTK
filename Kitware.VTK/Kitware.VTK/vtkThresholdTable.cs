using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThresholdTable : vtkTableAlgorithm
	{
		public enum ACCEPT_BETWEEN_WrapperEnum
		{
			ACCEPT_BETWEEN = 2,
			ACCEPT_GREATER_THAN = 1,
			ACCEPT_LESS_THAN = 0,
			ACCEPT_OUTSIDE = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdTable";

		public new static readonly string MRClassNameKey;

		static vtkThresholdTable()
		{
			vtkThresholdTable.MRClassNameKey = "class vtkThresholdTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThresholdTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdTable"));
		}

		public vtkThresholdTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdTable New()
		{
			vtkThresholdTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThresholdTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThresholdTable.vtkThresholdTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdTable_GetMode_01(HandleRef pThis);

		public virtual int GetMode()
		{
			return vtkThresholdTable.vtkThresholdTable_GetMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdTable_GetModeMaxValue_02(HandleRef pThis);

		public virtual int GetModeMaxValue()
		{
			return vtkThresholdTable.vtkThresholdTable_GetModeMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdTable_GetModeMinValue_03(HandleRef pThis);

		public virtual int GetModeMinValue()
		{
			return vtkThresholdTable.vtkThresholdTable_GetModeMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdTable_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThresholdTable.vtkThresholdTable_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkThresholdTable_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThresholdTable.vtkThresholdTable_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTable_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThresholdTable NewInstance()
		{
			vtkThresholdTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkThresholdTable_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThresholdTable SafeDownCast(vtkObjectBase o)
		{
			vtkThresholdTable vtkThresholdTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThresholdTable.vtkThresholdTable_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThresholdTable = (vtkThresholdTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThresholdTable.Register(null);
				}
			}
			return vtkThresholdTable;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkThresholdTable_SetMaxValue_09(HandleRef pThis, double v);

		public void SetMaxValue(double v)
		{
			vtkThresholdTable.vtkThresholdTable_SetMaxValue_09(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkThresholdTable_SetMinValue_10(HandleRef pThis, double v);

		public void SetMinValue(double v)
		{
			vtkThresholdTable.vtkThresholdTable_SetMinValue_10(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkThresholdTable_SetMode_11(HandleRef pThis, int _arg);

		public virtual void SetMode(int _arg)
		{
			vtkThresholdTable.vtkThresholdTable_SetMode_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkThresholdTable_ThresholdBetween_12(HandleRef pThis, double lower, double upper);

		public void ThresholdBetween(double lower, double upper)
		{
			vtkThresholdTable.vtkThresholdTable_ThresholdBetween_12(base.GetCppThis(), lower, upper);
		}
	}
}

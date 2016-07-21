using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWindowLevelLookupTable : vtkLookupTable
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowLevelLookupTable";

		public new static readonly string MRClassNameKey;

		static vtkWindowLevelLookupTable()
		{
			vtkWindowLevelLookupTable.MRClassNameKey = "class vtkWindowLevelLookupTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowLevelLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowLevelLookupTable"));
		}

		public vtkWindowLevelLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowLevelLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindowLevelLookupTable New()
		{
			vtkWindowLevelLookupTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWindowLevelLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_Build_01(HandleRef pThis);

		public override void Build()
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_Build_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindowLevelLookupTable_GetInverseVideo_02(HandleRef pThis);

		public virtual int GetInverseVideo()
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetInverseVideo_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkWindowLevelLookupTable_GetLevel_03(HandleRef pThis);

		public virtual double GetLevel()
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetLevel_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowLevelLookupTable_GetMaximumTableValue_04(HandleRef pThis);

		public virtual double[] GetMaximumTableValue()
		{
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMaximumTableValue_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_GetMaximumTableValue_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetMaximumTableValue(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMaximumTableValue_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_GetMaximumTableValue_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetMaximumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMaximumTableValue_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowLevelLookupTable_GetMinimumTableValue_07(HandleRef pThis);

		public virtual double[] GetMinimumTableValue()
		{
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMinimumTableValue_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_GetMinimumTableValue_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetMinimumTableValue(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMinimumTableValue_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_GetMinimumTableValue_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetMinimumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetMinimumTableValue_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkWindowLevelLookupTable_GetWindow_10(HandleRef pThis);

		public virtual double GetWindow()
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_GetWindow_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_InverseVideoOff_11(HandleRef pThis);

		public virtual void InverseVideoOff()
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_InverseVideoOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_InverseVideoOn_12(HandleRef pThis);

		public virtual void InverseVideoOn()
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_InverseVideoOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindowLevelLookupTable_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindowLevelLookupTable_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowLevelLookupTable_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWindowLevelLookupTable NewInstance()
		{
			vtkWindowLevelLookupTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowLevelLookupTable_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindowLevelLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkWindowLevelLookupTable vtkWindowLevelLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowLevelLookupTable = (vtkWindowLevelLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowLevelLookupTable.Register(null);
				}
			}
			return vtkWindowLevelLookupTable;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetInverseVideo_18(HandleRef pThis, int iv);

		public void SetInverseVideo(int iv)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetInverseVideo_18(base.GetCppThis(), iv);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetLevel_19(HandleRef pThis, double level);

		public void SetLevel(double level)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetLevel_19(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetMaximumTableValue_20(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetMaximumTableValue(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMaximumTableValue_20(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetMaximumTableValue_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetMaximumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMaximumTableValue_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetMinimumTableValue_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetMinimumTableValue(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMinimumTableValue_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetMinimumTableValue_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetMinimumTableValue(IntPtr _arg)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetMinimumTableValue_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindowLevelLookupTable_SetWindow_24(HandleRef pThis, double window);

		public void SetWindow(double window)
		{
			vtkWindowLevelLookupTable.vtkWindowLevelLookupTable_SetWindow_24(base.GetCppThis(), window);
		}
	}
}

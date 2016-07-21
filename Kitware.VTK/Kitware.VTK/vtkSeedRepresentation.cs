using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSeedRepresentation : vtkWidgetRepresentation
	{
		public enum NearSeed_WrapperEnum
		{
			NearSeed = 1,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSeedRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkSeedRepresentation()
		{
			vtkSeedRepresentation.MRClassNameKey = "class vtkSeedRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSeedRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSeedRepresentation"));
		}

		public vtkSeedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSeedRepresentation New()
		{
			vtkSeedRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSeedRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSeedRepresentation.vtkSeedRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkSeedRepresentation.vtkSeedRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_CreateHandle_03(HandleRef pThis, IntPtr e);

		public virtual int CreateHandle(IntPtr e)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_CreateHandle_03(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_GetActiveHandle_04(HandleRef pThis);

		public virtual int GetActiveHandle()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetActiveHandle_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedRepresentation_GetHandleRepresentation_05(HandleRef pThis, uint num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHandleRepresentation GetHandleRepresentation(uint num)
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_GetHandleRepresentation_05(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedRepresentation_GetHandleRepresentation_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHandleRepresentation GetHandleRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_GetHandleRepresentation_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_GetNumberOfSeeds_07(HandleRef pThis);

		public int GetNumberOfSeeds()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetNumberOfSeeds_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_GetSeedDisplayPosition_08(HandleRef pThis, uint seedNum, IntPtr pos);

		public virtual void GetSeedDisplayPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_GetSeedDisplayPosition_08(base.GetCppThis(), seedNum, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_GetSeedWorldPosition_09(HandleRef pThis, uint seedNum, IntPtr pos);

		public virtual void GetSeedWorldPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_GetSeedWorldPosition_09(base.GetCppThis(), seedNum, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_GetTolerance_10(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetTolerance_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_GetToleranceMaxValue_11(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetToleranceMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_GetToleranceMinValue_12(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_GetToleranceMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSeedRepresentation_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSeedRepresentation.vtkSeedRepresentation_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSeedRepresentation NewInstance()
		{
			vtkSeedRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_RemoveActiveHandle_17(HandleRef pThis);

		public virtual void RemoveActiveHandle()
		{
			vtkSeedRepresentation.vtkSeedRepresentation_RemoveActiveHandle_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_RemoveHandle_18(HandleRef pThis, int n);

		public virtual void RemoveHandle(int n)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_RemoveHandle_18(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_RemoveLastHandle_19(HandleRef pThis);

		public virtual void RemoveLastHandle()
		{
			vtkSeedRepresentation.vtkSeedRepresentation_RemoveLastHandle_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSeedRepresentation_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSeedRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSeedRepresentation vtkSeedRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSeedRepresentation.vtkSeedRepresentation_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSeedRepresentation = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSeedRepresentation.Register(null);
				}
			}
			return vtkSeedRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_SetHandleRepresentation_21(HandleRef pThis, HandleRef handle);

		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetHandleRepresentation_21(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_SetSeedDisplayPosition_22(HandleRef pThis, uint seedNum, IntPtr pos);

		public virtual void SetSeedDisplayPosition(uint seedNum, IntPtr pos)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetSeedDisplayPosition_22(base.GetCppThis(), seedNum, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSeedRepresentation_SetTolerance_23(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkSeedRepresentation.vtkSeedRepresentation_SetTolerance_23(base.GetCppThis(), _arg);
		}
	}
}

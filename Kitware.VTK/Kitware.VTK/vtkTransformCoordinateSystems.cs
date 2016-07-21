using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransformCoordinateSystems : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformCoordinateSystems";

		public new static readonly string MRClassNameKey;

		static vtkTransformCoordinateSystems()
		{
			vtkTransformCoordinateSystems.MRClassNameKey = "class vtkTransformCoordinateSystems";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformCoordinateSystems.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformCoordinateSystems"));
		}

		public vtkTransformCoordinateSystems(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCoordinateSystems_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformCoordinateSystems New()
		{
			vtkTransformCoordinateSystems result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransformCoordinateSystems() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformCoordinateSystems_GetInputCoordinateSystem_01(HandleRef pThis);

		public virtual int GetInputCoordinateSystem()
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetInputCoordinateSystem_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkTransformCoordinateSystems_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformCoordinateSystems_GetOutputCoordinateSystem_03(HandleRef pThis);

		public virtual int GetOutputCoordinateSystem()
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetOutputCoordinateSystem_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCoordinateSystems_GetViewport_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetViewport_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformCoordinateSystems_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformCoordinateSystems_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCoordinateSystems_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransformCoordinateSystems NewInstance()
		{
			vtkTransformCoordinateSystems result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformCoordinateSystems_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformCoordinateSystems SafeDownCast(vtkObjectBase o)
		{
			vtkTransformCoordinateSystems vtkTransformCoordinateSystems = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformCoordinateSystems = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformCoordinateSystems.Register(null);
				}
			}
			return vtkTransformCoordinateSystems;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystem_10(HandleRef pThis, int _arg);

		public virtual void SetInputCoordinateSystem(int _arg)
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystem_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToDisplay_11(HandleRef pThis);

		public void SetInputCoordinateSystemToDisplay()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystemToDisplay_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToViewport_12(HandleRef pThis);

		public void SetInputCoordinateSystemToViewport()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystemToViewport_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToWorld_13(HandleRef pThis);

		public void SetInputCoordinateSystemToWorld()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystemToWorld_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystem_14(HandleRef pThis, int _arg);

		public virtual void SetOutputCoordinateSystem(int _arg)
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystem_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToDisplay_15(HandleRef pThis);

		public void SetOutputCoordinateSystemToDisplay()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystemToDisplay_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToViewport_16(HandleRef pThis);

		public void SetOutputCoordinateSystemToViewport()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystemToViewport_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToWorld_17(HandleRef pThis);

		public void SetOutputCoordinateSystemToWorld()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystemToWorld_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformCoordinateSystems_SetViewport_18(HandleRef pThis, HandleRef viewport);

		public void SetViewport(vtkViewport viewport)
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetViewport_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}
	}
}

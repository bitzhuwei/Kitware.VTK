using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDynamic2DLabelMapper : vtkLabeledDataMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDynamic2DLabelMapper";

		public new static readonly string MRClassNameKey;

		static vtkDynamic2DLabelMapper()
		{
			vtkDynamic2DLabelMapper.MRClassNameKey = "class vtkDynamic2DLabelMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDynamic2DLabelMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDynamic2DLabelMapper"));
		}

		public vtkDynamic2DLabelMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamic2DLabelMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDynamic2DLabelMapper New()
		{
			vtkDynamic2DLabelMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDynamic2DLabelMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkDynamic2DLabelMapper_GetLabelHeightPadding_01(HandleRef pThis);

		public virtual float GetLabelHeightPadding()
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetLabelHeightPadding_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkDynamic2DLabelMapper_GetLabelWidthPadding_02(HandleRef pThis);

		public virtual float GetLabelWidthPadding()
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetLabelWidthPadding_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDynamic2DLabelMapper_GetReversePriority_03(HandleRef pThis);

		public virtual bool GetReversePriority()
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_GetReversePriority_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDynamic2DLabelMapper_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDynamic2DLabelMapper_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamic2DLabelMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDynamic2DLabelMapper NewInstance()
		{
			vtkDynamic2DLabelMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_RenderOpaqueGeometry_08(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_RenderOpaqueGeometry_08(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_RenderOverlay_09(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_RenderOverlay_09(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_ReversePriorityOff_10(HandleRef pThis);

		public virtual void ReversePriorityOff()
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_ReversePriorityOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_ReversePriorityOn_11(HandleRef pThis);

		public virtual void ReversePriorityOn()
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_ReversePriorityOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDynamic2DLabelMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDynamic2DLabelMapper SafeDownCast(vtkObjectBase o)
		{
			vtkDynamic2DLabelMapper vtkDynamic2DLabelMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDynamic2DLabelMapper = (vtkDynamic2DLabelMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDynamic2DLabelMapper.Register(null);
				}
			}
			return vtkDynamic2DLabelMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_SetLabelHeightPadding_13(HandleRef pThis, float _arg);

		public virtual void SetLabelHeightPadding(float _arg)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetLabelHeightPadding_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_SetLabelWidthPadding_14(HandleRef pThis, float _arg);

		public virtual void SetLabelWidthPadding(float _arg)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetLabelWidthPadding_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_SetPriorityArrayName_15(HandleRef pThis, string name);

		public void SetPriorityArrayName(string name)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetPriorityArrayName_15(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDynamic2DLabelMapper_SetReversePriority_16(HandleRef pThis, byte _arg);

		public virtual void SetReversePriority(bool _arg)
		{
			vtkDynamic2DLabelMapper.vtkDynamic2DLabelMapper_SetReversePriority_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}

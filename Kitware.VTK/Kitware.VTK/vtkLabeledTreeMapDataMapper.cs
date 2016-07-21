using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabeledTreeMapDataMapper : vtkLabeledDataMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledTreeMapDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkLabeledTreeMapDataMapper()
		{
			vtkLabeledTreeMapDataMapper.MRClassNameKey = "class vtkLabeledTreeMapDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabeledTreeMapDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledTreeMapDataMapper"));
		}

		public vtkLabeledTreeMapDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabeledTreeMapDataMapper New()
		{
			vtkLabeledTreeMapDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabeledTreeMapDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledTreeMapDataMapper_GetChildMotion_01(HandleRef pThis);

		public virtual int GetChildMotion()
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetChildMotion_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledTreeMapDataMapper_GetClipTextMode_02(HandleRef pThis);

		public virtual int GetClipTextMode()
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetClipTextMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledTreeMapDataMapper_GetDynamicLevel_03(HandleRef pThis);

		public virtual int GetDynamicLevel()
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetDynamicLevel_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_GetFontSizeRange_04(HandleRef pThis, IntPtr range);

		public void GetFontSizeRange(IntPtr range)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetFontSizeRange_04(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_GetInputTree_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTree GetInputTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetInputTree_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_GetLevelRange_06(HandleRef pThis, IntPtr range);

		public void GetLevelRange(IntPtr range)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetLevelRange_06(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledTreeMapDataMapper_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabeledTreeMapDataMapper_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabeledTreeMapDataMapper NewInstance()
		{
			vtkLabeledTreeMapDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_ReleaseGraphicsResources_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_RenderOpaqueGeometry_12(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_RenderOpaqueGeometry_12(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_RenderOverlay_13(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_RenderOverlay_13(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabeledTreeMapDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabeledTreeMapDataMapper vtkLabeledTreeMapDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledTreeMapDataMapper = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledTreeMapDataMapper.Register(null);
				}
			}
			return vtkLabeledTreeMapDataMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_SetChildMotion_15(HandleRef pThis, int _arg);

		public virtual void SetChildMotion(int _arg)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetChildMotion_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_SetClipTextMode_16(HandleRef pThis, int _arg);

		public virtual void SetClipTextMode(int _arg)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetClipTextMode_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_SetDynamicLevel_17(HandleRef pThis, int _arg);

		public virtual void SetDynamicLevel(int _arg)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetDynamicLevel_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_SetFontSizeRange_18(HandleRef pThis, int maxSize, int minSize, int delta);

		public void SetFontSizeRange(int maxSize, int minSize, int delta)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetFontSizeRange_18(base.GetCppThis(), maxSize, minSize, delta);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_SetLevelRange_19(HandleRef pThis, int startLevel, int endLevel);

		public void SetLevelRange(int startLevel, int endLevel)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetLevelRange_19(base.GetCppThis(), startLevel, endLevel);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabeledTreeMapDataMapper_SetRectanglesArrayName_20(HandleRef pThis, string name);

		public virtual void SetRectanglesArrayName(string name)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetRectanglesArrayName_20(base.GetCppThis(), name);
		}
	}
}

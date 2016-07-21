using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHardwareSelector : vtkObject
	{
		public enum PassTypes
		{
			ACTOR_PASS = 1,
			COMPOSITE_INDEX_PASS,
			ID_HIGH16 = 5,
			ID_LOW24 = 3,
			ID_MID24,
			MAX_KNOWN_PASS,
			MIN_KNOWN_PASS = 0,
			PROCESS_PASS = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkHardwareSelector";

		public new static readonly string MRClassNameKey;

		static vtkHardwareSelector()
		{
			vtkHardwareSelector.MRClassNameKey = "class vtkHardwareSelector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHardwareSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwareSelector"));
		}

		public vtkHardwareSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHardwareSelector New()
		{
			vtkHardwareSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHardwareSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHardwareSelector.vtkHardwareSelector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_BeginRenderProp_01(HandleRef pThis);

		public void BeginRenderProp()
		{
			vtkHardwareSelector.vtkHardwareSelector_BeginRenderProp_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkHardwareSelector_CaptureBuffers_02(HandleRef pThis);

		public virtual bool CaptureBuffers()
		{
			return vtkHardwareSelector.vtkHardwareSelector_CaptureBuffers_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_ClearBuffers_03(HandleRef pThis);

		public void ClearBuffers()
		{
			vtkHardwareSelector.vtkHardwareSelector_ClearBuffers_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_EndRenderProp_04(HandleRef pThis);

		public void EndRenderProp()
		{
			vtkHardwareSelector.vtkHardwareSelector_EndRenderProp_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_GenerateSelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection GenerateSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GenerateSelection_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_GenerateSelection_06(HandleRef pThis, IntPtr r, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection GenerateSelection(IntPtr r)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GenerateSelection_06(base.GetCppThis(), r, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_GenerateSelection_07(HandleRef pThis, uint x1, uint y1, uint x2, uint y2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection GenerateSelection(uint x1, uint y1, uint x2, uint y2)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GenerateSelection_07(base.GetCppThis(), x1, y1, x2, y2, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_GetArea_08(HandleRef pThis);

		public virtual uint[] GetArea()
		{
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetArea_08(base.GetCppThis());
			uint[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new uint[4];
				int[] array2 = new int[4];
				Marshal.Copy(intPtr, array2, 0, array.Length);
				for (int i = 0; i < 4; i++)
				{
					array[i] = (uint)array2[i];
				}
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_GetArea_09(HandleRef pThis, ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4);

		public virtual void GetArea(ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4)
		{
			vtkHardwareSelector.vtkHardwareSelector_GetArea_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_GetArea_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetArea(IntPtr _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_GetArea_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelector_GetCurrentPass_11(HandleRef pThis);

		public virtual int GetCurrentPass()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetCurrentPass_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelector_GetFieldAssociation_12(HandleRef pThis);

		public virtual int GetFieldAssociation()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetFieldAssociation_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkHardwareSelector_GetPixelInformation_13(HandleRef pThis, IntPtr display_position, ref int processId, ref long attrId, HandleRef prop);

		public bool GetPixelInformation(IntPtr display_position, ref int processId, ref long attrId, vtkProp prop)
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetPixelInformation_13(base.GetCppThis(), display_position, ref processId, ref attrId, (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkHardwareSelector_GetPixelInformation_14(HandleRef pThis, IntPtr display_position, ref int processId, ref long attrId, HandleRef prop, int maxDist);

		public bool GetPixelInformation(IntPtr display_position, ref int processId, ref long attrId, vtkProp prop, int maxDist)
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetPixelInformation_14(base.GetCppThis(), display_position, ref processId, ref attrId, (prop == null) ? default(HandleRef) : prop.GetCppThis(), maxDist) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelector_GetProcessID_15(HandleRef pThis);

		public virtual int GetProcessID()
		{
			return vtkHardwareSelector.vtkHardwareSelector_GetProcessID_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_GetPropFromID_16(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp GetPropFromID(int id)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetPropFromID_16(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_GetRenderer_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_GetRenderer_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelector_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelector_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHardwareSelector.vtkHardwareSelector_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHardwareSelector NewInstance()
		{
			vtkHardwareSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_RenderAttributeId_22(HandleRef pThis, long attribid);

		public void RenderAttributeId(long attribid)
		{
			vtkHardwareSelector.vtkHardwareSelector_RenderAttributeId_22(base.GetCppThis(), attribid);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_RenderCompositeIndex_23(HandleRef pThis, uint index);

		public void RenderCompositeIndex(uint index)
		{
			vtkHardwareSelector.vtkHardwareSelector_RenderCompositeIndex_23(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHardwareSelector SafeDownCast(vtkObjectBase o)
		{
			vtkHardwareSelector vtkHardwareSelector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareSelector = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareSelector.Register(null);
				}
			}
			return vtkHardwareSelector;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelector_Select_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSelection Select()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelector.vtkHardwareSelector_Select_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_SetArea_26(HandleRef pThis, uint _arg1, uint _arg2, uint _arg3, uint _arg4);

		public virtual void SetArea(uint _arg1, uint _arg2, uint _arg3, uint _arg4)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetArea_26(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_SetArea_27(HandleRef pThis, IntPtr _arg);

		public virtual void SetArea(IntPtr _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetArea_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_SetFieldAssociation_28(HandleRef pThis, int _arg);

		public virtual void SetFieldAssociation(int _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetFieldAssociation_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_SetProcessID_29(HandleRef pThis, int _arg);

		public virtual void SetProcessID(int _arg)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetProcessID_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelector_SetRenderer_30(HandleRef pThis, HandleRef arg0);

		public void SetRenderer(vtkRenderer arg0)
		{
			vtkHardwareSelector.vtkHardwareSelector_SetRenderer_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}

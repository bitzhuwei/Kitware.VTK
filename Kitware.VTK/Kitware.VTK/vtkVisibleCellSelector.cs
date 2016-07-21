using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVisibleCellSelector : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVisibleCellSelector";

		public new static readonly string MRClassNameKey;

		static vtkVisibleCellSelector()
		{
			vtkVisibleCellSelector.MRClassNameKey = "class vtkVisibleCellSelector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVisibleCellSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVisibleCellSelector"));
		}

		public vtkVisibleCellSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibleCellSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVisibleCellSelector New()
		{
			vtkVisibleCellSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibleCellSelector.vtkVisibleCellSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVisibleCellSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVisibleCellSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVisibleCellSelector.vtkVisibleCellSelector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibleCellSelector_GetActorFromId_01(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp GetActorFromId(long id)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibleCellSelector.vtkVisibleCellSelector_GetActorFromId_01(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkVisibleCellSelector_GetArea_02(HandleRef pThis, ref uint x0, ref uint y0, ref uint x1, ref uint y1);

		public void GetArea(ref uint x0, ref uint y0, ref uint x1, ref uint y1)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_GetArea_02(base.GetCppThis(), ref x0, ref y0, ref x1, ref y1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_GetPixelSelection_03(HandleRef pThis, IntPtr displayPos, ref long procId, ref long cellId, ref long vertId, HandleRef actorPtr);

		public void GetPixelSelection(IntPtr displayPos, ref long procId, ref long cellId, ref long vertId, vtkProp actorPtr)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_GetPixelSelection_03(base.GetCppThis(), displayPos, ref procId, ref cellId, ref vertId, (actorPtr == null) ? default(HandleRef) : actorPtr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkVisibleCellSelector_GetProcessorId_04(HandleRef pThis);

		public virtual uint GetProcessorId()
		{
			return vtkVisibleCellSelector.vtkVisibleCellSelector_GetProcessorId_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_GetSelectedIds_05(HandleRef pThis, HandleRef ToCopyInto);

		public void GetSelectedIds(vtkIdTypeArray ToCopyInto)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_GetSelectedIds_05(base.GetCppThis(), (ToCopyInto == null) ? default(HandleRef) : ToCopyInto.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_GetSelectedIds_06(HandleRef pThis, HandleRef ToCopyInto);

		public void GetSelectedIds(vtkSelection ToCopyInto)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_GetSelectedIds_06(base.GetCppThis(), (ToCopyInto == null) ? default(HandleRef) : ToCopyInto.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_GetSelectedVertices_07(HandleRef pThis, HandleRef VertexPointers, HandleRef VertexIds);

		public void GetSelectedVertices(vtkIdTypeArray VertexPointers, vtkIdTypeArray VertexIds)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_GetSelectedVertices_07(base.GetCppThis(), (VertexPointers == null) ? default(HandleRef) : VertexPointers.GetCppThis(), (VertexIds == null) ? default(HandleRef) : VertexIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibleCellSelector_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVisibleCellSelector.vtkVisibleCellSelector_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVisibleCellSelector_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVisibleCellSelector.vtkVisibleCellSelector_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibleCellSelector_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVisibleCellSelector NewInstance()
		{
			vtkVisibleCellSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibleCellSelector.vtkVisibleCellSelector_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVisibleCellSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_PrintSelectedIds_12(HandleRef pThis, HandleRef IdsToPrint);

		public void PrintSelectedIds(vtkIdTypeArray IdsToPrint)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_PrintSelectedIds_12(base.GetCppThis(), (IdsToPrint == null) ? default(HandleRef) : IdsToPrint.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVisibleCellSelector_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVisibleCellSelector SafeDownCast(vtkObjectBase o)
		{
			vtkVisibleCellSelector vtkVisibleCellSelector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVisibleCellSelector.vtkVisibleCellSelector_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVisibleCellSelector = (vtkVisibleCellSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVisibleCellSelector.Register(null);
				}
			}
			return vtkVisibleCellSelector;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_Select_14(HandleRef pThis);

		public void Select()
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_Select_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_SetArea_15(HandleRef pThis, uint x0, uint y0, uint x1, uint y1);

		public void SetArea(uint x0, uint y0, uint x1, uint y1)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_SetArea_15(base.GetCppThis(), x0, y0, x1, y1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_SetProcessorId_16(HandleRef pThis, uint pid);

		public virtual void SetProcessorId(uint pid)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_SetProcessorId_16(base.GetCppThis(), pid);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_SetRenderPasses_17(HandleRef pThis, int DoProcessor, int DoActor, int DoCellIdHi, int DoCellIdMid, int DoCellIdLo, int DoVertexId);

		public void SetRenderPasses(int DoProcessor, int DoActor, int DoCellIdHi, int DoCellIdMid, int DoCellIdLo, int DoVertexId)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_SetRenderPasses_17(base.GetCppThis(), DoProcessor, DoActor, DoCellIdHi, DoCellIdMid, DoCellIdLo, DoVertexId);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVisibleCellSelector_SetRenderer_18(HandleRef pThis, HandleRef arg0);

		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkVisibleCellSelector.vtkVisibleCellSelector_SetRenderer_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}

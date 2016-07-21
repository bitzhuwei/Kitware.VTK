using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPainterPolyDataMapper : vtkPolyDataMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPainterPolyDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkPainterPolyDataMapper()
		{
			vtkPainterPolyDataMapper.MRClassNameKey = "class vtkPainterPolyDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPainterPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPainterPolyDataMapper"));
		}

		public vtkPainterPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPainterPolyDataMapper New()
		{
			vtkPainterPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPainterPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPainterPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterPolyDataMapper_GetPainter_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPainter GetPainter()
		{
			vtkPainter vtkPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_GetPainter_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPainter = (vtkPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPainter.Register(null);
				}
			}
			return vtkPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterPolyDataMapper_GetSelectionPainter_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPainter GetSelectionPainter()
		{
			vtkPainter vtkPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_GetSelectionPainter_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPainter = (vtkPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPainter.Register(null);
				}
			}
			return vtkPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPainterPolyDataMapper_GetSupportsSelection_03(HandleRef pThis);

		public override bool GetSupportsSelection()
		{
			return vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_GetSupportsSelection_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterPolyDataMapper_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPainterPolyDataMapper_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_MapDataArrayToMultiTextureAttribute_06(HandleRef pThis, int unit, string dataArrayName, int fieldAssociation, int componentno);

		public override void MapDataArrayToMultiTextureAttribute(int unit, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_MapDataArrayToMultiTextureAttribute_06(base.GetCppThis(), unit, dataArrayName, fieldAssociation, componentno);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_MapDataArrayToVertexAttribute_07(HandleRef pThis, string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno);

		public override void MapDataArrayToVertexAttribute(string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_MapDataArrayToVertexAttribute_07(base.GetCppThis(), vertexAttributeName, dataArrayName, fieldAssociation, componentno);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterPolyDataMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPainterPolyDataMapper NewInstance()
		{
			vtkPainterPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPainterPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_RemoveAllVertexAttributeMappings_11(HandleRef pThis);

		public override void RemoveAllVertexAttributeMappings()
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_RemoveAllVertexAttributeMappings_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_RemoveVertexAttributeMapping_12(HandleRef pThis, string vertexAttributeName);

		public override void RemoveVertexAttributeMapping(string vertexAttributeName)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_RemoveVertexAttributeMapping_12(base.GetCppThis(), vertexAttributeName);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_RenderPiece_13(HandleRef pThis, HandleRef ren, HandleRef act);

		public override void RenderPiece(vtkRenderer ren, vtkActor act)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_RenderPiece_13(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPainterPolyDataMapper_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPainterPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkPainterPolyDataMapper vtkPainterPolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPainterPolyDataMapper = (vtkPainterPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPainterPolyDataMapper.Register(null);
				}
			}
			return vtkPainterPolyDataMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_SetPainter_15(HandleRef pThis, HandleRef arg0);

		public void SetPainter(vtkPainter arg0)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_SetPainter_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPainterPolyDataMapper_SetSelectionPainter_16(HandleRef pThis, HandleRef arg0);

		public void SetSelectionPainter(vtkPainter arg0)
		{
			vtkPainterPolyDataMapper.vtkPainterPolyDataMapper_SetSelectionPainter_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}

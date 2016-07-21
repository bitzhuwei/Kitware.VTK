using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkPolyDataMapper : vtkMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataMapper()
		{
			vtkPolyDataMapper.MRClassNameKey = "class vtkPolyDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapper"));
		}

		public vtkPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataMapper New()
		{
			vtkPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataMapper.vtkPolyDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper_GetBounds_01(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_GetBounds_02(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper_GetGhostLevel_03(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetGhostLevel_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper_GetNumberOfPieces_05(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetNumberOfPieces_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper_GetNumberOfSubPieces_06(HandleRef pThis);

		public virtual int GetNumberOfSubPieces()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetNumberOfSubPieces_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper_GetPiece_07(HandleRef pThis);

		public virtual int GetPiece()
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_GetPiece_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataMapper.vtkPolyDataMapper_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_MapDataArrayToMultiTextureAttribute_10(HandleRef pThis, int unit, string dataArrayName, int fieldAssociation, int componentno);

		public virtual void MapDataArrayToMultiTextureAttribute(int unit, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_MapDataArrayToMultiTextureAttribute_10(base.GetCppThis(), unit, dataArrayName, fieldAssociation, componentno);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_MapDataArrayToVertexAttribute_11(HandleRef pThis, string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno);

		public virtual void MapDataArrayToVertexAttribute(string vertexAttributeName, string dataArrayName, int fieldAssociation, int componentno)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_MapDataArrayToVertexAttribute_11(base.GetCppThis(), vertexAttributeName, dataArrayName, fieldAssociation, componentno);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataMapper NewInstance()
		{
			vtkPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_RemoveAllVertexAttributeMappings_14(HandleRef pThis);

		public virtual void RemoveAllVertexAttributeMappings()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_RemoveAllVertexAttributeMappings_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_RemoveVertexAttributeMapping_15(HandleRef pThis, string vertexAttributeName);

		public virtual void RemoveVertexAttributeMapping(string vertexAttributeName)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_RemoveVertexAttributeMapping_15(base.GetCppThis(), vertexAttributeName);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_Render_16(HandleRef pThis, HandleRef ren, HandleRef act);

		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_Render_16(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_RenderPiece_17(HandleRef pThis, HandleRef ren, HandleRef act);

		public virtual void RenderPiece(vtkRenderer ren, vtkActor act)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_RenderPiece_17(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataMapper vtkPolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper.vtkPolyDataMapper_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper.Register(null);
				}
			}
			return vtkPolyDataMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_SetGhostLevel_19(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetGhostLevel_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_SetInput_20(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkPolyData arg0)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetInput_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_SetNumberOfPieces_21(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetNumberOfPieces_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_SetNumberOfSubPieces_22(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubPieces(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetNumberOfSubPieces_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_SetPiece_23(HandleRef pThis, int _arg);

		public virtual void SetPiece(int _arg)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_SetPiece_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_ShallowCopy_24(HandleRef pThis, HandleRef m);

		public new void ShallowCopy(vtkAbstractMapper m)
		{
			vtkPolyDataMapper.vtkPolyDataMapper_ShallowCopy_24(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper_Update_25(HandleRef pThis);

		public override void Update()
		{
			vtkPolyDataMapper.vtkPolyDataMapper_Update_25(base.GetCppThis());
		}
	}
}

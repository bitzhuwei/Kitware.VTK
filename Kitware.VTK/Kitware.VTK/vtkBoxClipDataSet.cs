using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoxClipDataSet : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxClipDataSet";

		public new static readonly string MRClassNameKey;

		static vtkBoxClipDataSet()
		{
			vtkBoxClipDataSet.MRClassNameKey = "class vtkBoxClipDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxClipDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxClipDataSet"));
		}

		public vtkBoxClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxClipDataSet New()
		{
			vtkBoxClipDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoxClipDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoxClipDataSet.vtkBoxClipDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_CellGrid_01(HandleRef pThis, long typeobj, long npts, IntPtr cellIds, HandleRef newCellArray);

		public void CellGrid(long typeobj, long npts, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_CellGrid_01(base.GetCppThis(), typeobj, npts, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipBox_02(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipBox(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox_02(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipBox0D_03(HandleRef pThis, HandleRef cell, HandleRef locator, HandleRef verts, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipBox0D(vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox0D_03(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipBox1D_04(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef lines, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipBox1D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox1D_04(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipBox2D_05(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipBox2D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipBox2D_05(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron_06(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipHexahedron(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron_06(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron0D_07(HandleRef pThis, HandleRef cell, HandleRef locator, HandleRef verts, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipHexahedron0D(vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron0D_07(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron1D_08(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef lines, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipHexahedron1D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray lines, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron1D_08(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_ClipHexahedron2D_09(HandleRef pThis, HandleRef newPoints, HandleRef cell, HandleRef locator, HandleRef tets, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public void ClipHexahedron2D(vtkPoints newPoints, vtkGenericCell cell, vtkIncrementalPointLocator locator, vtkCellArray tets, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_ClipHexahedron2D_09(base.GetCppThis(), (newPoints == null) ? default(HandleRef) : newPoints.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tets == null) ? default(HandleRef) : tets.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_CreateDefaultLocator_10(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_CreateDefaultLocator_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_CreateTetra_11(HandleRef pThis, long npts, IntPtr cellIds, HandleRef newCellArray);

		public void CreateTetra(long npts, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_CreateTetra_11(base.GetCppThis(), npts, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_GenerateClipScalarsOff_12(HandleRef pThis);

		public virtual void GenerateClipScalarsOff()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClipScalarsOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_GenerateClipScalarsOn_13(HandleRef pThis);

		public virtual void GenerateClipScalarsOn()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClipScalarsOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_GenerateClippedOutputOff_14(HandleRef pThis);

		public virtual void GenerateClippedOutputOff()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClippedOutputOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_GenerateClippedOutputOn_15(HandleRef pThis);

		public virtual void GenerateClippedOutputOn()
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_GenerateClippedOutputOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxClipDataSet_GetClippedOutput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_GetClippedOutput_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBoxClipDataSet_GetGenerateClipScalars_17(HandleRef pThis);

		public virtual int GetGenerateClipScalars()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetGenerateClipScalars_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBoxClipDataSet_GetGenerateClippedOutput_18(HandleRef pThis);

		public virtual int GetGenerateClippedOutput()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetGenerateClippedOutput_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxClipDataSet_GetLocator_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_GetLocator_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkBoxClipDataSet_GetMTime_20(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetMTime_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBoxClipDataSet_GetNumberOfOutputs_21(HandleRef pThis);

		public virtual int GetNumberOfOutputs()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetNumberOfOutputs_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkBoxClipDataSet_GetOrientation_22(HandleRef pThis);

		public virtual uint GetOrientation()
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_GetOrientation_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_InterpolateEdge_23(HandleRef attributes, long toId, long fromId1, long fromId2, double t);

		public static void InterpolateEdge(vtkDataSetAttributes attributes, long toId, long fromId1, long fromId2, double t)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_InterpolateEdge_23((attributes == null) ? default(HandleRef) : attributes.GetCppThis(), toId, fromId1, fromId2, t);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBoxClipDataSet_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBoxClipDataSet_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoxClipDataSet.vtkBoxClipDataSet_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_MinEdgeF_26(HandleRef pThis, IntPtr id_v, IntPtr cellIds, IntPtr edgF);

		public void MinEdgeF(IntPtr id_v, IntPtr cellIds, IntPtr edgF)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_MinEdgeF_26(base.GetCppThis(), id_v, cellIds, edgF);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxClipDataSet_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoxClipDataSet NewInstance()
		{
			vtkBoxClipDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_PyramidToTetra_29(HandleRef pThis, IntPtr pyramId, IntPtr cellIds, HandleRef newCellArray);

		public void PyramidToTetra(IntPtr pyramId, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_PyramidToTetra_29(base.GetCppThis(), pyramId, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxClipDataSet_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxClipDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkBoxClipDataSet vtkBoxClipDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxClipDataSet.vtkBoxClipDataSet_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxClipDataSet = (vtkBoxClipDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxClipDataSet.Register(null);
				}
			}
			return vtkBoxClipDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_SetBoxClip_31(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void SetBoxClip(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetBoxClip_31(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_SetBoxClip_32(HandleRef pThis, IntPtr n0, IntPtr o0, IntPtr n1, IntPtr o1, IntPtr n2, IntPtr o2, IntPtr n3, IntPtr o3, IntPtr n4, IntPtr o4, IntPtr n5, IntPtr o5);

		public void SetBoxClip(IntPtr n0, IntPtr o0, IntPtr n1, IntPtr o1, IntPtr n2, IntPtr o2, IntPtr n3, IntPtr o3, IntPtr n4, IntPtr o4, IntPtr n5, IntPtr o5)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetBoxClip_32(base.GetCppThis(), n0, o0, n1, o1, n2, o2, n3, o3, n4, o4, n5, o5);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_SetGenerateClipScalars_33(HandleRef pThis, int _arg);

		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetGenerateClipScalars_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_SetGenerateClippedOutput_34(HandleRef pThis, int _arg);

		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetGenerateClippedOutput_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_SetLocator_35(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetLocator_35(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_SetOrientation_36(HandleRef pThis, uint _arg);

		public virtual void SetOrientation(uint _arg)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_SetOrientation_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBoxClipDataSet_WedgeToTetra_37(HandleRef pThis, IntPtr wedgeId, IntPtr cellIds, HandleRef newCellArray);

		public void WedgeToTetra(IntPtr wedgeId, IntPtr cellIds, vtkCellArray newCellArray)
		{
			vtkBoxClipDataSet.vtkBoxClipDataSet_WedgeToTetra_37(base.GetCppThis(), wedgeId, cellIds, (newCellArray == null) ? default(HandleRef) : newCellArray.GetCppThis());
		}
	}
}

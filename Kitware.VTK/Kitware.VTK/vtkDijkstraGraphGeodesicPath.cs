using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDijkstraGraphGeodesicPath : vtkGraphGeodesicPath
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDijkstraGraphGeodesicPath";

		public new static readonly string MRClassNameKey;

		static vtkDijkstraGraphGeodesicPath()
		{
			vtkDijkstraGraphGeodesicPath.MRClassNameKey = "class vtkDijkstraGraphGeodesicPath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDijkstraGraphGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDijkstraGraphGeodesicPath"));
		}

		public vtkDijkstraGraphGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDijkstraGraphGeodesicPath New()
		{
			vtkDijkstraGraphGeodesicPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDijkstraGraphGeodesicPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_GetCumulativeWeights_01(HandleRef pThis, HandleRef weights);

		public virtual void GetCumulativeWeights(vtkDoubleArray weights)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetCumulativeWeights_01(base.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDijkstraGraphGeodesicPath_GetGeodesicLength_02(HandleRef pThis);

		public override double GetGeodesicLength()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetGeodesicLength_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_GetIdList_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdList GetIdList()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetIdList_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraGraphGeodesicPath_GetRepelPathFromVertices_04(HandleRef pThis);

		public virtual int GetRepelPathFromVertices()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetRepelPathFromVertices_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_GetRepelVertices_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetRepelVertices()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetRepelVertices_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraGraphGeodesicPath_GetStopWhenEndReached_06(HandleRef pThis);

		public virtual int GetStopWhenEndReached()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetStopWhenEndReached_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraGraphGeodesicPath_GetUseScalarWeights_07(HandleRef pThis);

		public virtual int GetUseScalarWeights()
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_GetUseScalarWeights_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraGraphGeodesicPath_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDijkstraGraphGeodesicPath_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDijkstraGraphGeodesicPath NewInstance()
		{
			vtkDijkstraGraphGeodesicPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOff_12(HandleRef pThis);

		public virtual void RepelPathFromVerticesOff()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOn_13(HandleRef pThis);

		public virtual void RepelPathFromVerticesOn()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_RepelPathFromVerticesOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDijkstraGraphGeodesicPath_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDijkstraGraphGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkDijkstraGraphGeodesicPath vtkDijkstraGraphGeodesicPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDijkstraGraphGeodesicPath = (vtkDijkstraGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDijkstraGraphGeodesicPath.Register(null);
				}
			}
			return vtkDijkstraGraphGeodesicPath;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetRepelPathFromVertices_15(HandleRef pThis, int _arg);

		public virtual void SetRepelPathFromVertices(int _arg)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetRepelPathFromVertices_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetRepelVertices_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetRepelVertices(vtkPoints arg0)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetRepelVertices_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetStopWhenEndReached_17(HandleRef pThis, int _arg);

		public virtual void SetStopWhenEndReached(int _arg)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetStopWhenEndReached_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_SetUseScalarWeights_18(HandleRef pThis, int _arg);

		public virtual void SetUseScalarWeights(int _arg)
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_SetUseScalarWeights_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOff_19(HandleRef pThis);

		public virtual void StopWhenEndReachedOff()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOn_20(HandleRef pThis);

		public virtual void StopWhenEndReachedOn()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_StopWhenEndReachedOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_UseScalarWeightsOff_21(HandleRef pThis);

		public virtual void UseScalarWeightsOff()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_UseScalarWeightsOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDijkstraGraphGeodesicPath_UseScalarWeightsOn_22(HandleRef pThis);

		public virtual void UseScalarWeightsOn()
		{
			vtkDijkstraGraphGeodesicPath.vtkDijkstraGraphGeodesicPath_UseScalarWeightsOn_22(base.GetCppThis());
		}
	}
}

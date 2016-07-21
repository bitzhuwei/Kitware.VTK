using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataPointSampler : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPointSampler";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataPointSampler()
		{
			vtkPolyDataPointSampler.MRClassNameKey = "class vtkPolyDataPointSampler";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataPointSampler.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPointSampler"));
		}

		public vtkPolyDataPointSampler(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointSampler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataPointSampler New()
		{
			vtkPolyDataPointSampler result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointSampler.vtkPolyDataPointSampler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataPointSampler() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataPointSampler.vtkPolyDataPointSampler_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateEdgePointsOff_01(HandleRef pThis);

		public virtual void GenerateEdgePointsOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateEdgePointsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateEdgePointsOn_02(HandleRef pThis);

		public virtual void GenerateEdgePointsOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateEdgePointsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateInteriorPointsOff_03(HandleRef pThis);

		public virtual void GenerateInteriorPointsOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateInteriorPointsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateInteriorPointsOn_04(HandleRef pThis);

		public virtual void GenerateInteriorPointsOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateInteriorPointsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateVertexPointsOff_05(HandleRef pThis);

		public virtual void GenerateVertexPointsOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVertexPointsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateVertexPointsOn_06(HandleRef pThis);

		public virtual void GenerateVertexPointsOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVertexPointsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateVerticesOff_07(HandleRef pThis);

		public virtual void GenerateVerticesOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVerticesOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_GenerateVerticesOn_08(HandleRef pThis);

		public virtual void GenerateVerticesOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVerticesOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPolyDataPointSampler_GetDistance_09(HandleRef pThis);

		public virtual double GetDistance()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetDistance_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPolyDataPointSampler_GetDistanceMaxValue_10(HandleRef pThis);

		public virtual double GetDistanceMaxValue()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetDistanceMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPolyDataPointSampler_GetDistanceMinValue_11(HandleRef pThis);

		public virtual double GetDistanceMinValue()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetDistanceMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointSampler_GetGenerateEdgePoints_12(HandleRef pThis);

		public virtual int GetGenerateEdgePoints()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateEdgePoints_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointSampler_GetGenerateInteriorPoints_13(HandleRef pThis);

		public virtual int GetGenerateInteriorPoints()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateInteriorPoints_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointSampler_GetGenerateVertexPoints_14(HandleRef pThis);

		public virtual int GetGenerateVertexPoints()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateVertexPoints_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointSampler_GetGenerateVertices_15(HandleRef pThis);

		public virtual int GetGenerateVertices()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateVertices_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointSampler_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataPointSampler_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointSampler_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataPointSampler NewInstance()
		{
			vtkPolyDataPointSampler result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointSampler.vtkPolyDataPointSampler_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataPointSampler_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataPointSampler SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataPointSampler vtkPolyDataPointSampler = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataPointSampler.vtkPolyDataPointSampler_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataPointSampler = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataPointSampler.Register(null);
				}
			}
			return vtkPolyDataPointSampler;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_SetDistance_21(HandleRef pThis, double _arg);

		public virtual void SetDistance(double _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetDistance_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_SetGenerateEdgePoints_22(HandleRef pThis, int _arg);

		public virtual void SetGenerateEdgePoints(int _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateEdgePoints_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_SetGenerateInteriorPoints_23(HandleRef pThis, int _arg);

		public virtual void SetGenerateInteriorPoints(int _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateInteriorPoints_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_SetGenerateVertexPoints_24(HandleRef pThis, int _arg);

		public virtual void SetGenerateVertexPoints(int _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateVertexPoints_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataPointSampler_SetGenerateVertices_25(HandleRef pThis, int _arg);

		public virtual void SetGenerateVertices(int _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateVertices_25(base.GetCppThis(), _arg);
		}
	}
}

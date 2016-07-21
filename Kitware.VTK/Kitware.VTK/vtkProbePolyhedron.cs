using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProbePolyhedron : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProbePolyhedron";

		public new static readonly string MRClassNameKey;

		static vtkProbePolyhedron()
		{
			vtkProbePolyhedron.MRClassNameKey = "class vtkProbePolyhedron";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProbePolyhedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbePolyhedron"));
		}

		public vtkProbePolyhedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbePolyhedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProbePolyhedron New()
		{
			vtkProbePolyhedron result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProbePolyhedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProbePolyhedron.vtkProbePolyhedron_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProbePolyhedron_GetProbeCellData_01(HandleRef pThis);

		public virtual int GetProbeCellData()
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_GetProbeCellData_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProbePolyhedron_GetProbePointData_02(HandleRef pThis);

		public virtual int GetProbePointData()
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_GetProbePointData_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbePolyhedron_GetSource_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_GetSource_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProbePolyhedron_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProbePolyhedron_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProbePolyhedron.vtkProbePolyhedron_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbePolyhedron_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProbePolyhedron NewInstance()
		{
			vtkProbePolyhedron result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_ProbeCellDataOff_08(HandleRef pThis);

		public virtual void ProbeCellDataOff()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbeCellDataOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_ProbeCellDataOn_09(HandleRef pThis);

		public virtual void ProbeCellDataOn()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbeCellDataOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_ProbePointDataOff_10(HandleRef pThis);

		public virtual void ProbePointDataOff()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbePointDataOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_ProbePointDataOn_11(HandleRef pThis);

		public virtual void ProbePointDataOn()
		{
			vtkProbePolyhedron.vtkProbePolyhedron_ProbePointDataOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProbePolyhedron_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProbePolyhedron SafeDownCast(vtkObjectBase o)
		{
			vtkProbePolyhedron vtkProbePolyhedron = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProbePolyhedron.vtkProbePolyhedron_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProbePolyhedron = (vtkProbePolyhedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProbePolyhedron.Register(null);
				}
			}
			return vtkProbePolyhedron;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_SetProbeCellData_13(HandleRef pThis, int _arg);

		public virtual void SetProbeCellData(int _arg)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetProbeCellData_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_SetProbePointData_14(HandleRef pThis, int _arg);

		public virtual void SetProbePointData(int _arg)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetProbePointData_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_SetSource_15(HandleRef pThis, HandleRef source);

		public void SetSource(vtkPolyData source)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetSource_15(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProbePolyhedron_SetSourceConnection_16(HandleRef pThis, HandleRef algOutput);

		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkProbePolyhedron.vtkProbePolyhedron_SetSourceConnection_16(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTexturedSphereSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedSphereSource";

		public new static readonly string MRClassNameKey;

		static vtkTexturedSphereSource()
		{
			vtkTexturedSphereSource.MRClassNameKey = "class vtkTexturedSphereSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedSphereSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedSphereSource"));
		}

		public vtkTexturedSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedSphereSource New()
		{
			vtkTexturedSphereSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedSphereSource.vtkTexturedSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTexturedSphereSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTexturedSphereSource.vtkTexturedSphereSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetPhi_01(HandleRef pThis);

		public virtual double GetPhi()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhi_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetPhiMaxValue_02(HandleRef pThis);

		public virtual double GetPhiMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetPhiMinValue_03(HandleRef pThis);

		public virtual double GetPhiMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_GetPhiResolution_04(HandleRef pThis);

		public virtual int GetPhiResolution()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiResolution_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_GetPhiResolutionMaxValue_05(HandleRef pThis);

		public virtual int GetPhiResolutionMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiResolutionMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_GetPhiResolutionMinValue_06(HandleRef pThis);

		public virtual int GetPhiResolutionMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetPhiResolutionMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetRadius_07(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetRadiusMaxValue_08(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetRadiusMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetRadiusMinValue_09(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetRadiusMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetTheta_10(HandleRef pThis);

		public virtual double GetTheta()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetTheta_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetThetaMaxValue_11(HandleRef pThis);

		public virtual double GetThetaMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTexturedSphereSource_GetThetaMinValue_12(HandleRef pThis);

		public virtual double GetThetaMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_GetThetaResolution_13(HandleRef pThis);

		public virtual int GetThetaResolution()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaResolution_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_GetThetaResolutionMaxValue_14(HandleRef pThis);

		public virtual int GetThetaResolutionMaxValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaResolutionMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_GetThetaResolutionMinValue_15(HandleRef pThis);

		public virtual int GetThetaResolutionMinValue()
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_GetThetaResolutionMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTexturedSphereSource_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTexturedSphereSource.vtkTexturedSphereSource_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedSphereSource_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTexturedSphereSource NewInstance()
		{
			vtkTexturedSphereSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedSphereSource.vtkTexturedSphereSource_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedSphereSource_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedSphereSource SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedSphereSource vtkTexturedSphereSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedSphereSource.vtkTexturedSphereSource_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedSphereSource = (vtkTexturedSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedSphereSource.Register(null);
				}
			}
			return vtkTexturedSphereSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTexturedSphereSource_SetPhi_21(HandleRef pThis, double _arg);

		public virtual void SetPhi(double _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetPhi_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTexturedSphereSource_SetPhiResolution_22(HandleRef pThis, int _arg);

		public virtual void SetPhiResolution(int _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetPhiResolution_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTexturedSphereSource_SetRadius_23(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetRadius_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTexturedSphereSource_SetTheta_24(HandleRef pThis, double _arg);

		public virtual void SetTheta(double _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetTheta_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTexturedSphereSource_SetThetaResolution_25(HandleRef pThis, int _arg);

		public virtual void SetThetaResolution(int _arg)
		{
			vtkTexturedSphereSource.vtkTexturedSphereSource_SetThetaResolution_25(base.GetCppThis(), _arg);
		}
	}
}

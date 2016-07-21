using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSliceCubes : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliceCubes";

		public new static readonly string MRClassNameKey;

		static vtkSliceCubes()
		{
			vtkSliceCubes.MRClassNameKey = "class vtkSliceCubes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliceCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliceCubes"));
		}

		public vtkSliceCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliceCubes New()
		{
			vtkSliceCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSliceCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSliceCubes.vtkSliceCubes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceCubes_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSliceCubes.vtkSliceCubes_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceCubes_GetLimitsFileName_02(HandleRef pThis);

		public virtual string GetLimitsFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSliceCubes.vtkSliceCubes_GetLimitsFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceCubes_GetReader_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkVolumeReader GetReader()
		{
			vtkVolumeReader vtkVolumeReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_GetReader_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeReader = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeReader.Register(null);
				}
			}
			return vtkVolumeReader;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSliceCubes_GetValue_04(HandleRef pThis);

		public virtual double GetValue()
		{
			return vtkSliceCubes.vtkSliceCubes_GetValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSliceCubes_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSliceCubes.vtkSliceCubes_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSliceCubes_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSliceCubes.vtkSliceCubes_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceCubes_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSliceCubes NewInstance()
		{
			vtkSliceCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSliceCubes_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliceCubes SafeDownCast(vtkObjectBase o)
		{
			vtkSliceCubes vtkSliceCubes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliceCubes = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliceCubes.Register(null);
				}
			}
			return vtkSliceCubes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSliceCubes_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkSliceCubes.vtkSliceCubes_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSliceCubes_SetLimitsFileName_11(HandleRef pThis, string _arg);

		public virtual void SetLimitsFileName(string _arg)
		{
			vtkSliceCubes.vtkSliceCubes_SetLimitsFileName_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSliceCubes_SetReader_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetReader(vtkVolumeReader arg0)
		{
			vtkSliceCubes.vtkSliceCubes_SetReader_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSliceCubes_SetValue_13(HandleRef pThis, double _arg);

		public virtual void SetValue(double _arg)
		{
			vtkSliceCubes.vtkSliceCubes_SetValue_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSliceCubes_Update_14(HandleRef pThis);

		public void Update()
		{
			vtkSliceCubes.vtkSliceCubes_Update_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSliceCubes_Write_15(HandleRef pThis);

		public void Write()
		{
			vtkSliceCubes.vtkSliceCubes_Write_15(base.GetCppThis());
		}
	}
}
